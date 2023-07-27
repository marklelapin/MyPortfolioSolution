// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code

/*------------------------------------
	My Portfolio Filter
-------------------------------------- */


var currentProjectsFilter = "*"
const projectsFilterMenu = document.querySelectorAll("[data-filter]");
const projects = document.querySelectorAll(".project");


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








	

	







                


