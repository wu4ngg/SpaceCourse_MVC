var global;
function changePage(element) {
    clearTimeout();
    global = element;
    var btn = document.getElementById("back_button");
    var main = document.getElementById("main");
    var profile = document.getElementById(element);
    btn.style.display = "block"
    main.style.transform = "translate(-100px, 0)"
    main.style.opacity = "0%"
    profile.style.transform = "translate(0px, 0)"
    profile.style.opacity = "100%"
    setTimeout(() => {
        profile.classList.remove("hidden")
        main.style.display = "none"
    }, 500)
}
function back() {
    clearTimeout();
    var main = document.getElementById("main");
    var profile = document.getElementById(global);
    var btn = document.getElementById("back_button");
    btn.style.display = "none"
    main.style.transform = "translate(0,0)"
    main.style.opacity = "100%"
    profile.style.transform = "translate(100px,0)"
    profile.style.opacity = "0%"
    setTimeout(() => {
        profile.classList.add("hidden")
        main.style.display = "flex"
    }, 500)
}
function showProfile() {
    clearTimeout()
    var userinf = document.getElementById("user-inf");
    userinf.style.display = "block"
    userinf.style.top = "12vh"
    userinf.style.opacity = "100%"
}
function hideProfile() {
    var userinf = document.getElementById("user-inf");
    userinf.style.top = "10vh"
    userinf.style.opacity = "0%"
    setTimeout(() => {
        userinf.style.display = "none"
    }, 500)
    back()
}
// 
// show spaceship
var jsShowSpace = document.querySelector('.roketjs');
var htmlShowSpace = document.querySelector('.rokethtml');
var cssShowSpace = document.querySelector('.roketcss');
var apiShowSpace = document.querySelector('.roketapi');
var rbShowSpace = document.querySelector('.roketruby');
var lnShowSpace = document.querySelector('.roketlinux');
var sqShowSpace = document.querySelector('.roketsql');
function HoverShow(element) {
    clearTimeout();
    var a = ['box_roket1', 'box_roket2', 'box_roket3', 'box_roket4', 'box_roket5', 'box_roket6', 'box_roket7'];
    if (element.classList[1] == a[0]) {
        jsShowSpace.classList.add('show_roket');
    }
    else if (element.classList[1] == a[1]) {
        htmlShowSpace.classList.add('show_roket');
    }
    else if (element.classList[1] == a[2]) {
        cssShowSpace.classList.add('show_roket');
    }
    else if (element.classList[1] == a[3]) {
        apiShowSpace.classList.add('show_roket');
    }
    else if (element.classList[1] == a[4]) {
        rbShowSpace.classList.add('show_roket');
    }
    else if (element.classList[1] == a[5]) {
        lnShowSpace.classList.add('show_roket');
    } else {
        sqShowSpace.classList.add('show_roket')
    }

    // htmlShowSpace.classList.add('show_roket');
    // cssShowSpace.classList.add('show_roket');
    // apiShowSpace.classList.add('show_roket');
}
function HoverHide(element) {
    if (element.classList[1]) {
        jsShowSpace.classList.add('show_roket');
    }
    jsShowSpace.classList.remove('show_roket');
    htmlShowSpace.classList.remove('show_roket');
    cssShowSpace.classList.remove('show_roket');
    apiShowSpace.classList.remove('show_roket');
    rbShowSpace.classList.remove('show_roket');
    lnShowSpace.classList.remove('show_roket');
    sqShowSpace.classList.remove('show_roket')

}
// Show course 
var courseShow = document.querySelector(".course_popup-box");
var courseShow1 = document.querySelector(".course_popup-box1");
var courseShow2 = document.querySelector(".course_popup-box2");
var courseShow3 = document.querySelector(".course_popup-box3");
var courseShow4 = document.querySelector(".course_popup-box4");
var courseShow5 = document.querySelector(".course_popup-box5");
var courseShow6 = document.querySelector(".course_popup-box6");

function HoverShowCourse(element) {
    clearTimeout();
    if (element == 0) {
        courseShow.classList.add('show_course--js');
    } else if (element == 1) {
        courseShow1.classList.add('show_course--js');
    }
    else if (element == 2) {
        courseShow2.classList.add('show_course--js');
    }
    else if (element == 3) {
        courseShow3.classList.add('show_course--js');
        window.scrollTo(courseShow3)
    }
    else if (element == 4) {
        courseShow4.classList.add('show_course--js');
        window.scrollTo(courseShow4)
    }
    else if (element == 5) {
        courseShow5.classList.add('show_course--js');
        window.scrollTo(courseShow5)
    }
    else if (element == 6) {
        courseShow6.classList.add('show_course--js');
        window.scrollTo(courseShow5)
    }
}
function HoverHideCourse(element) {

    if (element == 0) {
        courseShow.classList.remove('show_course--js');
    }
    else if (element == 1) {
        courseShow1.classList.remove('show_course--js');
    }
    else if (element == 2) {
        courseShow2.classList.remove('show_course--js');
    }
    else if (element == 3) {
        courseShow3.classList.remove('show_course--js');
    }
    else if (element == 4) {
        courseShow4.classList.remove('show_course--js');
    }
    else if (element == 5) {
        courseShow5.classList.remove('show_course--js');
    }
    else if (element == 6) {
        courseShow6.classList.remove('show_course--js');
    }
}