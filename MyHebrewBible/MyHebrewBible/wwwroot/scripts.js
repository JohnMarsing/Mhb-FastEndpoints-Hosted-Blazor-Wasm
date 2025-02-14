// wwwroot/scripts.js
function scrollToElementById(elementId) {
  var element = document.getElementById(elementId);
  if (element) {
    //console.log(`Element with ID '${elementId}' WAS found.`);
    element.scrollIntoView({ behavior: 'smooth', block: 'start' });
  }
  //else {
  //  console.log(`Element with ID '${elementId}' was NOT found.`);
  //}
}
