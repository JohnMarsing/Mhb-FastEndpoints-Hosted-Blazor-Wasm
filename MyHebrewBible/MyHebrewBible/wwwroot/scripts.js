
// Called by:
function setFocusToElement(elementId) {
  var element = document.getElementById(elementId);
  if (element) {
    //console.log(`Element with ID '${elementId}' WAS found.`);
    element.focus();
  }
  //else {
  //  console.log(`Element with ID '${elementId}' was NOT found.`);
  //}
}

// Called by: Only called by  Parasha!ReportWrapper!ReturnedScriptureId
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
