function isEmpty(id) {
    return document.getElementById(id).innerHTML.trim() == ""
}

console.log(isEmpty("past"));