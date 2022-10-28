function redirect(){
    window.location.href = "http://www.w3schools.com";
}
function makevisible(){
    var box = document.getElementById("se");
    console.log(box.classList);
    box.classList.add("visible")
}
function makeinvis(){
    var box = document.getElementById("se");
    box.classList.add("novis")
    setTimeout(() => {
        box.classList.remove("visible")
        box.classList.remove("novis")
    }, 500)
    //box.classList.remove("visible")
}
function loginclick(){
    var box = document.getElementById("sd");
    box.classList.add("visible")
}
function loginquit(){
    
    var box = document.getElementById("sd");
    box.classList.add("novis")
    setTimeout(() => {
        box.classList.remove("visible")
        box.classList.remove("novis")
    }, 500)
}
function registerclick(){
    var box = document.getElementById("register1");
    box.classList.add("visible");
    console.log(box);
}
function registerquit(){
    var box = document.getElementById("register1");
    box.classList.add("novis")
    setTimeout(() => {
        box.classList.remove("visible")
        box.classList.remove("novis")
    }, 500)
}

// Handle Login

const wrapLogin = document.querySelector('#sd');
const wrapLoginChild = document.querySelector('.logindialog');
wrapLogin.addEventListener('click', loginquit)
wrapLoginChild.addEventListener('click', function(e){
    e.stopPropagation();
})
// handle Register

const wrapRegis = document.querySelector('.register-main'); 
const wrapRegisChild = document.querySelector('.register-wrap');
const wrapRegisChange = document.querySelector('.btn_wrapper-login');

wrapRegisChild.addEventListener('click', function(e){
    e.stopPropagation();
})
wrapRegis.addEventListener('click', registerquit);
wrapRegisChange.addEventListener('click', function(){
    registerquit();
    setTimeout(() => {
        loginclick();
    }, 500)
})

var prevScrollpos = 0;
console.log(prevScrollpos);
window.onscroll = function() {
  var currentScrollPos = window.pageYOffset;
  console.log(currentScrollPos);
  if (prevScrollpos <= 200) {
    document.getElementById("header").classList.remove("header_white");
    document.getElementById("info-box").classList.remove("visible_box");
  } else {
    document.getElementById("header").classList.add("header_white");
    document.getElementById("info-box").classList.add("visible_box");
  }
  prevScrollpos = currentScrollPos;
}
var btnExplore1 = document.querySelector('.btn_explore1');
var btnExplore2 = document.querySelector('.btn_explore2');
var btnExplore3 = document.querySelector('.btn_explore3');

function showBtnExplore(element) {
    if (element.classList[1] == 'card1') {
        btnExplore1.classList.add('js-show--btn_explore');
    }
    else if (element.classList[1] == 'card2') {
        btnExplore2.classList.add('js-show--btn_explore');
    }
    else {
        btnExplore3.classList.add('js-show--btn_explore');
    }
}
function hiddenBtnExplore(element) {
    if (element.classList[1] == 'card1') {
        btnExplore1.classList.remove('js-show--btn_explore');
    }
    else if (element.classList[1] == 'card2') {
        btnExplore2.classList.remove('js-show--btn_explore');
    }
    else {
        btnExplore3.classList.remove('js-show--btn_explore');
    }
}