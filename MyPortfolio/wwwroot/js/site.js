// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code


'use strict';

var currentProjectsFilter = "*"
const projectsFilterMenu = document.querySelectorAll("[data-filter]");
const projects = document.querySelectorAll(".project");

const mouseExists = false// matchMedia('(pointer:fine)').matches;

//Contact Form Ajax
document.forms[0].onsubmit = (event) => { //TODO - as part of making the contact form a 'component' refer specifically to contact form not just form[0] 
    event.preventDefault();

    let formData = new FormData(document.forms[0]);
    let elementTarget = event.currentTarget;
    let targetModalSuffix = elementTarget.getAttribute("data-modalSuffix");
    let targetModal = new bootstrap.Modal(document.getElementById('modal-' + targetModalSuffix), { keyboard: false })
    let targetModalMessage = document.getElementById('modal-body-' + targetModalSuffix)
    let targetModalButton = document.getElementById('modal-button-' + targetModalSuffix)

    targetModalMessage.innerHTML = "Sending message...";
    targetModalButton.style = "display: none";

    targetModal.show()
    fetch('?handler=SendMessage', {
        method: 'post',
        body: new URLSearchParams(formData)
    })
        .then((response) => response.text())
        .then((result) => {
            if (result == "Success") {
                targetModalMessage.innerHTML = "Message Sent Successfully!";
                resetContactForm;

            } else {
                targetModalMessage.innerHTML = "Failed! - Please try again later or email me directly on magcarter@hotmail.co.uk";
            };

            targetModalButton.style = "display: block";
        });
};


function resetContactForm() {
    var contactMessage = document.getElementById("contact_message")
    contactMessage.value = '';
    contactMessage.setAttribute("placeholder", "Send me another message....")
}



/*------------------------------------
    My Portfolio Filter
-------------------------------------- */


$(window).on('load', function () {
    $(".portfolio-menu").find("a").on("click", projectsFilterClick);

});

function projectsFilterClick(event) {
    event.preventDefault();
    const element = event.currentTarget

    currentProjectsFilter = element.getAttribute("data-filter")

    updateFilterMenu()

    updateProjectsFilter()
}


function updateFilterMenu() {
    projectsFilterMenu.forEach(el => {
        el.classList.remove("active");
        dataFilter = el.getAttribute("data-filter")
        if (dataFilter === currentProjectsFilter) { el.classList.add("active") }
    })
}

function updateProjectsFilter() {
    projects.forEach(el => {
        el.classList.remove("dimmed");
        if (el.classList.contains(currentProjectsFilter) === false && currentProjectsFilter != "*") { el.classList.add("dimmed") };
    })
}



/*------------------------------------
    My Project Modal
-------------------------------------- */

document.querySelectorAll(".project-box").forEach(element => element.addEventListener("click", (event) => handleProjectBoxClick(event, element)));
document.querySelectorAll(".close-modal-on-click").forEach(element => element.addEventListener("click", (e) => closeProjectModals(e)));
if (mouseExists === false) {
    document.querySelectorAll(".action-link").forEach(element => {
        element.classList.add("show");
        element.addEventListener("click", (event) => handleActionLink(event, element));
    });
}


function handleProjectBoxClick(event, projectBox) {

    if (mouseExists) {
        if (projectBox.classList.contains("open-modal-on-click")) openProjectModal(event, projectBox);
        return;
    }
    //mouseDoesNotExist
    toggleTouched(projectBox);
}

function toggleTouched(projectBox) {
    if (projectBox.classList.contains("touched")) {
        projectBox.classList.remove("touched")
    } else {
        projectBox.classList.add("touched")
    }

    document.querySelectorAll(".project-box").forEach(element => {
        if (element !== projectBox) { element.classList.remove("touched") }
    });
}


function handleActionLink(event, element) {

    
    const link = element.getAttribute("data-link");
    if (link === "project-details") {
        const projectBox = element.closest(".project-box");
        console.log('actionlink project-details',projectBox)
        openProjectModal(event, projectBox);
     
    } else {
        window.open(link, "_blank");
    }
}



function openProjectModal(event, projectOverlay) {

    //go straight to modal
    document.getElementById("portfolio-modal").classList.remove("closed");
    const projectId = projectOverlay.closest(".project").getAttribute("id");
    const projectDetail = document.getElementById("project-detail-" + projectId);
    projectDetail.classList.add("show");

}

function closeProjectModals(event) {
    event.preventDefault();
    document.getElementById("portfolio-modal").classList.add("closed");
    document.querySelectorAll(".project-detail-container").forEach(projectDetail => projectDetail.classList.remove("show"));

}
















