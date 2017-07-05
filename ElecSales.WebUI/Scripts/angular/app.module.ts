import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { HttpModule } from '@angular/http';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';//����������ڽ��ˢ����ҳ404������

//ָ��;
//1.��� - ӵ��ģ���ָ��  //����Component
//2.�ṹ��ָ�� - ͨ����Ӻ��Ƴ�DomԪ�ظı�Dom ���ֵ�ָ��   ����:NgFor.NgIf
//3.������ָ�� - �ı�Ԫ��,���������ָ�����ۺ���Ϊ��ָ�� ����:HighlightDirective

//Components  ��� - ӵ��ģ���ָ��
import { AppComponent } from "./Component/app.component";


@NgModule({
  imports: [
    BrowserModule,
    //�����Ҫʹ��[(ngModel)]���Ƶı��ʽ,��Ҫ�������FormsModule
    FormsModule,
    HttpModule
  ],
  declarations: [//����Ӧ�������ݸ�ģ���������ܵ���ָ����б�
    AppComponent
  ],
  providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }],//���ｫHeroService��ȫ��ע��,��ʱ�κ����������ܷ�����
  bootstrap: [AppComponent]
})
export class AppModule { }

