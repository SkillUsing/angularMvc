# angularMvc
 之前用了angularJs并将其结合MVC和Web api 使用,使用比较方便.
 而新的angular出现之后当然免不了要试试,而且项目需要.
 此项目作为项目模板贡献大家.
 
# AngularMvc 和 angularKendo

> 前端:angular,angularKendo                            
> 后端:Mvc,WebApi         


# 使用方式
```
$ npm clone https://github.com/SkillUsing/angularMvc.git              
$ npm cd angularMvc            
$ npm i  或者 cnpm i              
$ npm start 或者 VS中F5 或者 编译后直接使用iis加载网站.            
// 在项目中添加了2中启动方式,一种是使用VS直接编译的模式,另一种是通过npm start 来启动.
// 区别在于：
// npm start 启动会编译angular以及TypeScript,将angular的最新修改直接展示出来,但是通过webApi来调用远程数据会有跨域的问题
// vs 中按F5 则会完整的打开项目,但是angular以及TypeScript需要手动编译,并且GET请求需要清除缓存.
```

# 注意
> 需要注意的是angular2.x 版本和 angular4.0 版本在文件关联性上有一点差异,详细查询官方文档,这里不做表述.           
> angularKendo 作为引用需要填写配置SystemJS,否则会提示找不到.           
  
