let chatUser = document.getElementsByClassName("chat-user-message-titles");
let root = document.querySelector(":root");
let chatUserTitleOption = document.querySelector(".cu-round-shape");

// making a function to run
function scrollhover() {
  root.style.setProperty("--pseudo-backgroundcolor", "#BCC0C4");
}

// todo creating mouse enter and mouse leave function
// function showOption() {
//   chatUserTitleOption.style.display = "block";
// }
// function hideOption() {
//   chatUserTitleOption.style.display = "none";
// }

$(document).ready(function () {
  
  $(".chat-user-message-titles").mouseenter(function () {
    // $(".cu-round-shape").show();
    $(this).find('.cu-round-shape').show();
  });
  $(".chat-user-message-titles").mouseleave(function () {
    $(".cu-round-shape").hide();
  });
  $(".cb-user").mouseenter(function () {
   $(this).find(".cb-option-shape").show();
  });
  $(".cb-user").mouseleave(function () {
    $(".cb-option-shape").hide();
  });
  $(".cb-own").mouseenter(function () {
   $(this).find(".cb-option-shape").show();
  });
  $(".cb-own").mouseleave(function () {
    $(".cb-option-shape").hide();
  });

  // todo this one is for chat icons
  $(".ci-add-drawer").hide();
  $('.cia-add-option').click(function (e) { 
    e.preventDefault();
  $(".cia-option-close").toggle();
    $('.ci-add-drawer').toggle();
  });
});


// .todo this is chatbox 
var div = document.querySelector('.chat-input-messagebox');
var ta =  document.querySelector('textarea');

ta.addEventListener('keydown', autosize);

function autosize() {
  setTimeout(function() {
    ta. style.cssText = 'height:auto'; 

    var height = Math.min(20 * 2, ta.scrollHeight);
    // div.style.cssText = 'height:' + height + 'px';
    ta. style.cssText = 'height:' + height + 'px';
  },0);
}