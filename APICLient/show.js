const urlParams = new URLSearchParams(window.location.search);
const tableName= urlParams.get('table');

function init()
{
	let content = document.getElementById("content");
	SetTitle();
	let table = document.createElement("table")
	table.id = "list";
	table.className = "list";
	content.appendChild(table);
	GetAllElements();
}

function SetTitle()
{
	let content = document.getElementById("content");

	let title = document.createElement("h1");
	title.className = "center title";
	let titleText = document.createTextNode(tableName)
	title.appendChild(titleText);
	content.appendChild(title);

	let seperator = document.createElement("div");
	seperator.classNames = "flow-right controls";
	content.appendChild(seperator);

	let addButton = document.createElement("button");
	addButton.className = "new-button center";
	let addButtonText = document.createTextNode("New "+tableName);
	addButton.appendChild(addButtonText);
	addButton.onclick = function () {
        location.href = "./create.html?table="+tableName;
	}
	content.appendChild(addButton);
}

async function DeleteElement(id)
{

	let url = "https://localhost:5001/api/"+tableName+"/"+id;
	const myHeaders = new Headers();
	let response = await fetch(url,{method:'DELETE'});
	let status = await response.status;
	var row = document.getElementById(tableName+" "+id);
	row.remove();
} 

async function GetAllElements()
{
	let url = "https://localhost:5001/api/"+tableName;
	const myHeaders = new Headers();
	let response = await fetch(url);
	let body = await response.json();
	const outTable = document.getElementById('list')

	for(let i=0;i<body.length; i++)
	{
		let row = document.createElement("tr");
		let id = 0;
		row.index = tableName+" "+i;
		for(let key in body[i])
		{
			if (body[i].hasOwnProperty(key)) {
				let column = document.createElement("td");
				let txt = document.createTextNode(body[i][key]);
				if(key==="id")
					id = body[i][key];
				column.appendChild(txt)
				row.appendChild(column)
			}
		}
		
		let actions = document.createElement("td")
		let deleteButton = document.createElement("button");
		deleteButton.onclick = function() {DeleteElement(id)};
		let deleteButtonText = document.createTextNode("delete");
		deleteButton.appendChild(deleteButtonText);
		actions.appendChild(deleteButton);
		
		let seperator = document.createTextNode(" ");
		actions.appendChild(seperator);

		let editButton = document.createElement("button");
		editButton.onclick = function() {location.href = "./edit.html?table="+tableName+"&id="+id;};
		let editButtonText = document.createTextNode("edit");
		editButton.appendChild(editButtonText);
		actions.appendChild(editButton);

		row.appendChild(actions);
		outTable.appendChild(row);
	}
}