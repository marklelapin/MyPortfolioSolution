// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code

/*------------------------------------
	My Portfolio Filter
-------------------------------------- */


var currentProjectsFilter = "*"
const projectsFilterMenu = document.querySelectorAll("[data-filter]");
const projects = document.querySelectorAll(".project");


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










	

	







                


