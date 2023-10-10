let input = document.querySelector(".search-form__tag-input");
let tagList = document.querySelector(".search-form__tag-list");
let tags = [];

input.addEventListener("keydown", e => {
    let text = input.value.trim();

    if(text === "" && e.keyCode === 8 && tags.length !== 0) {
        tags.pop();
        tagList.lastChild.remove();
    }

    if(e.keyCode === 32) {
        e.preventDefault();
        if(text === "") return input.value = "";
        if(tagList.clientWidth > vw(70)) return input.placeholder = "";

        appendTag(text);
        input.value = "";
    }
})

function appendTag(tag) {
    let tagElem = document.createElement("span");
    tagElem.className = "search-form__tag";
    tagElem.innerText = tag;
    tagList.appendChild(tagElem);
    tags.push(tag)
}

function vw(percent) {
    let width = Math.max(document.documentElement.clientWidth, window.innerWidth || 0);
    return (percent * width) / 100;
}