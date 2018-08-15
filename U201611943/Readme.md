# 微信小程序初尝试
## 程序介绍
    该程序主要构造了两个微信小程序页面，并且配置两个标签按钮通过点击使页面切换，主要的功能是实现一个60秒倒计时，并加入了一些文字和图片点缀，同时用到了页面布局的程序。
## 程序测试
程序是在*微信web开发者工具*上编写完成，在进行测试时应先安装上述工具，然后直接运行文件，在模拟器上即可查看效果。
## 项目使用
本项目是我对微信小程序的初步探索，仅实现了倒计时、设置标签栏，页面转换和排版等功能，没有实际的运用效果，但起到了熟悉开发环境、语言，文件设置，基本框架的作用。
## 主要代码
### 60秒倒计时
```java

// 从从60到到0倒计时

function countdown(that) {

  var second = that.data.second

  if (second == 0) {

    that.setData({

      second: "开始发牌！"

    });

    return;

  }

  var time = setTimeout(function () {

    that.setData({

      second: second - 1

    });

    countdown(that);

  }

    , 1000)

}



Page({

  data: {

    second: 60

  },

  onLoad: function () {

    countdown(this);

  }

});
```
### 文本格式
```java
.container{
  background-color:#eee;
  height:100vh;
  display:flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
}
```
### 设置标签栏
```java
{
 "pages":["pages/djs/djs","pages/v/v"
 ],
 "tabBar":{
   "list":[
     {
       "text": "发牌",
      "pagePath": "pages/djs/djs",
      "iconPath": "images/1.png",
      "selectedIconPath": "images/4.png"
     },
     {
       "text": "公司简介",
      "pagePath": "pages/v/v",
      "iconPath": "images/2.png",
      "selectedIconPath": "images/3.png"
     }
   ],
   "color":"#000",
   "selectedColor":"#00f"
 }
}
```
### 文本框
```java
<view class="container">
  <image src="/images/hg.jpg"></image>
  <text>六十秒后开始发牌: </text>
  <text> {{second}}</text>
 <text>警告:未滿18岁者請勿進入本站!</text>
 <text>注意自我保护,适度娱乐</text>
 <text>合理安排时间,享受健康生活</text>
 <text>@康氏娱乐</text>
</view>
```
### 小程序标题栏
```java
{
  "navigationBarTitleText":"性感荷官 在线发牌",
"navigationBarBackgroundColor":"#fff",
"navigationBarTextStyle":"black"
}
```
*ps:其它相似代码未列出。*
## 项目图示
![在线发牌](./1.png "详情见图片")
![公司简介](./2.png "详情见图片")
## 参考资料
主要参考老师提供的[视频](https://www.bilibili.com/video/av25037513/?p=2)资料。

***
## 项目作者
气卓1601李睿康
## 致谢
石东源老师及助教
