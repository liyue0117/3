
//index.js

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
