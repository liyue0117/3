# 陈达的demo
## 用途
网址导航  
## 如何运行
双击navigation.html
## 示意图
![图片丢失](image/navigation.png "运行结果")
## 代码

```JavaScript

<head>
<title></title>
<script type="text/javascript">

function initEven() 
{
  var guides = document.getElementById("guide"); 
  var lis = guides.getElementsByTagName("li"); 
  for (var i =0; i < lis.length; i++)
  { 
     var li = lis[i];
     li.onmouseover =function()      //当鼠标移动到某个li上时执行
     { 
          var guides = document.getElementById("guide"); 
          var lis = guides.getElementsByTagName("li");
          for (var i =0; i < lis.length; i++)
          { 
              var li = lis[i];
              if (li ==this) 
              {
                 li.style.background ="yellow"; //将当前背景设为黄色
                 this.style.fontSize =30;  //将字体设为30号
              }
              else 
              {
                li.style.background ="white"; //将其余背景设为白色
                li.style.fontSize =18; //将其余字体设为18号
              }
          }
     }
  }
}
</script>
</head>

<body onload="initEven()">
<ul id="guide">
网站导航<br/><br/>
<li><a href="https://www.baidu.com/">百度</a></li>
<li><a href="https://cn.bing.com/">必应</a></li>
<li><a href="https://www.google.com.hk/">谷歌</a></li>
<li><a href="https://github.com/jtext103/SoftwareEngneering/">课程资料</a></li>
<li><a href="http://www.w3school.com.cn/js/">JS教程</a></li>
</ul>
</body>

```