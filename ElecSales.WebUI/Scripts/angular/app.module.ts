import { LOCALE_ID, NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { HttpModule } from '@angular/http';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';//这个导入用于解决刷新网页404的问题
import { ButtonsModule } from '@progress/kendo-angular-buttons';

//指令;
//1.组件 - 拥有模板的指令  //所有Component
//2.结构型指令 - 通过添加和移除Dom元素改变Dom 布局的指令   例如:NgFor.NgIf
//3.属性型指令 - 改变元素,组件或其他指令的外观和行为的指令 例如:HighlightDirective

//Components  组件 - 拥有模板的指令
import { AppComponent } from "./Component/app.component";


@NgModule({
  imports: [
    BrowserModule,
    //如果想要使用[(ngModel)]类似的表达式,需要引入这个FormsModule
    FormsModule,
    HttpModule,
    ButtonsModule
  ],
  declarations: [//包含应用中数据该模块的组件、管道和指令的列表
    AppComponent
  ],
  providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }],//这里将HeroService在全局注册,此时任何子容器都能访问它
  bootstrap: [AppComponent]
})
export class AppModule { }

