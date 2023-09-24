var map = document.querySelector('iframe');
var center = map.getBoundingClientRect().centerX;
map.style.left = center - map.offsetWidth / 2 + 'px';
