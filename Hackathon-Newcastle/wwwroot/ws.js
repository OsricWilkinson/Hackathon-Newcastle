"use strict";

window.Backend = (function () {

    function buildWebsocket() {
        const target = "ws://" + window.location.host + "/ws";
        return new WebSocket(target);
    }

    const ws = buildWebsocket();
    const handlers = {};

    ws.onmessage = (msg) => {
        let packet;
        try {
            packet = JSON.parse(msg.data);
        } catch (ex) {
            console.warn("Bad JSON from the server, ignoring", msg);
            return;
        }
            
        if (packet.type in handlers) {
            for (let i = 0; i < handlers[packet.type]; i += 1) {
                try {
                    handlers[packet.type][i](packet);
                } catch (ex) {
                    console.error("Problem in handler", ex);
                }
            }
        } else {
            console.log("Ignored packet", packet);
        }
    };

    function _send(msg) {
        ws.send(JSON.stringify(msg));
    }

    function _on(type, handler) {
        if (!(type in handlers)) {
            handlers[type] = {};
        }

        hanlders[type].push(handler);
    }

    return {
        on: _on,
        send: _send
    }

})();

