"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var AppComponent = (function () {
    function AppComponent() {
        this.name = 'Angular';
    }
    AppComponent.prototype.onButtonClick = function () {
        this.name = 'Kendo UI';
    };
    return AppComponent;
}());
AppComponent = __decorate([
    core_1.Component({
        selector: '[my-app]',
        styleUrls: [
            // load the Kendo UI Default theme
            'node_modules/@progress/kendo-theme-default/dist/all.css'
        ],
        template: "\n    <h1>Hello {{name}}!</h1>\n    <button kendoButton (click)=\"onButtonClick()\" [primary]=\"true\">My Kendo UI Button</button> \n  "
    })
], AppComponent);
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map