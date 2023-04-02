mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
    console.log(" Hello world");
  },

  
  GiMePlane: function () {
    myGameInstance.SendMessage('Yadex', 'SetName',player.getName());
    myGameInstance.SendMessage('Yadex', 'SetPhoto',player.getPhoto("medium"));
  }, 

  RateGame: function () {

   ysdk.feedback.canReview()
   .then(({ value, reason }) => {
    if (value) {
      ysdk.feedback.requestReview()
      .then(({ feedbackSent }) => {
        console.log(feedbackSent);
      })
    } else {
      console.log(reason)
    }
  })

 },
 SaveExtern: function(date) {
  var dateString = UTF8ToString(date);
  var myobj = JSON.parse(dateString);
  player.setData(myobj);
},

LoadExtern: function (){
  player.getData().then(_data => {
    const myJSON = JSON.stringify(_date);
    myGameInstance.SendMessage('Progress', 'SetPlayerInfo', myJSON);
  });
},

});
