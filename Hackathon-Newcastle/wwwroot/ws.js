"use strict";

window.Backend = (function () {

    function buildWebsocket() {
        const target = "ws://" + window.location.host + "/ws";
        return new WebSocket(target);
    }

    const ws = buildWebsocket();
    const handlers = {};

    ws.onmessage = (msg) => {
        try {
            const packet = JSON.parse(msg.data);

        } catch (ex) {
            console.warn("Bad JSON from the server, ignoring", msg);
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

