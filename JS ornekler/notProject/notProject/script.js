const notesContainer = document.querySelector(".notes-container");
const createBtn = document.querySelector(".btn");
let notes = document.querySelector("input-box");


function showNot() {

    notesContainer.innerHTML = localStorage.getItem("notes");

}