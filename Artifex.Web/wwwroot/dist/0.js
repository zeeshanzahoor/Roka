webpackJsonp([0],{

/***/ 1543:
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/* WEBPACK VAR INJECTION */(function(module) {

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _react = __webpack_require__(1);

var _react2 = _interopRequireDefault(_react);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

(function () {
    var enterModule = __webpack_require__(14).enterModule;

    enterModule && enterModule(module);
})();

var MyComp = function MyComp() {
    return _react2.default.createElement(
        "h1",
        null,
        "Dynamic loaded"
    );
};
var _default = MyComp;
exports.default = _default;
;

(function () {
    var reactHotLoader = __webpack_require__(14).default;

    var leaveModule = __webpack_require__(14).leaveModule;

    if (!reactHotLoader) {
        return;
    }

    reactHotLoader.register(MyComp, "MyComp", "D:/ArtifexPay/ArtifexPay/Artifex.Web/Artifex/Modules/Dashboard/Test.js");
    reactHotLoader.register(_default, "default", "D:/ArtifexPay/ArtifexPay/Artifex.Web/Artifex/Modules/Dashboard/Test.js");
    leaveModule(module);
})();

;
/* WEBPACK VAR INJECTION */}.call(exports, __webpack_require__(19)(module)))

/***/ })

});
//# sourceMappingURL=0.js.map