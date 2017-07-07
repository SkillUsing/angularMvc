"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var common_1 = require("@angular/common"); //这个导入用于解决刷新网页404的问题
var kendo_angular_buttons_1 = require("@progress/kendo-angular-buttons");
//指令;
//1.组件 - 拥有模板的指令  //所有Component
//2.结构型指令 - 通过添加和移除Dom元素改变Dom 布局的指令   例如:NgFor.NgIf
//3.属性型指令 - 改变元素,组件或其他指令的外观和行为的指令 例如:HighlightDirective
//Components  组件 - 拥有模板的指令
var app_component_1 = require("./Component/app.component");
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            //如果想要使用[(ngModel)]类似的表达式,需要引入这个FormsModule
            forms_1.FormsModule,
            http_1.HttpModule,
            kendo_angular_buttons_1.ButtonsModule
        ],
        declarations: [
            app_component_1.AppComponent
        ],
        providers: [{ provide: common_1.LocationStrategy, useClass: common_1.HashLocationStrategy }],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map