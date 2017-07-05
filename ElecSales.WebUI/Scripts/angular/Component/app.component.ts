import { Component } from '@angular/core'
@Component({
  selector: "my-app",
  styleUrls: ["app.component.css"],
  template: `
<h1>{{title}}</h1>
`,
  moduleId: module.id
})

export class AppComponent {
  title = "英雄编辑器";
}