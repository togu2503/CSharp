
const urlParams = new URLSearchParams(window.location.search);
const tableName = urlParams.get('table');

const elementId = urlParams.get('id'); 

var myBody;

function init()
{
	let content = document.getElementById("content");
	SetTitle();
	let table = document.createElement("table")
	table.id = "list";
	table.className = "list";
	content.appendChild(table);
	GetElement();
}

async function Edit()
{

	let url = "https://localhost:5001/api/"+tableName;
	  async function postData(url = '', data = {}) {
		// Default options are marked with *
		const response = await fetch(url, {
		  method: 'POST', // *GET, POST, PUT, DELETE, etc.
		  mode: 'cors', // no-cors, *cors, same-origin
		  cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
		  credentials: 'same-origin', // include, *same-origin, omit
		  headers: {
			'Content-Type': 'application/json'
			// 'Content-Type': 'application/x-www-form-urlencoded',
		  },
		  redirect: 'follow', // manual, *follow, error
		  referrerPolicy: 'no-referrer', // no-referrer, *client
		  body: JSON.stringify(data) // body data type must match "Content-Type" header
		});
		return await response.json(); // parses JSON response into native JavaScript objects
	  }
	  
	  postData(url, myBody)
		.then((data) => {
		  console.log(data); // JSON data parsed by `response.json()` call
		});
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
	let addButtonText = document.createTextNode("Create");
	addButton.appendChild(addButtonText);
	addButton.onclick = function () {
        Edit()
	}
	content.appendChild(addButton);
}

async function GetElement()
{
	const urlParams = new URLSearchParams(window.location.search);
	let elementId = urlParams.get('id');

	let url = "https://localhost:5001/api/"+tableName;
	const myHeaders = new Headers();
	let response = await fetch(url);
	let wholeTable = await response.json();
	myBody = wholeTable[wholeTable.length - 1];
	const outTable = document.getElementById('list')

	let row = document.createElement("tr");
	let id = 0;
	let count = 0;
	row.index = tableName+" "+0;

	for(let key in myBody)
	{
		count += 1
		if (myBody.hasOwnProperty(key)) {
			let column = document.createElement("td");
			let label = document.createElement("label");
			label.textContent = key;
			label.htmlFor = key;
			let editBox = document.createElement("input");
			editBox.value = "";
			editBox.onchange = function(){ myBody[key] = editBox.value}
			if(key==="id")
			{
				id = myBody[key]+1;
				editBox.value = id;
			}
			if(count>4)
			{
				count = 0;

				outTable.appendChild(row);
				row = document.createElement("tr");
			}
			column.appendChild(label);
			column.appendChild(document.createElement("p"));
			column.appendChild(editBox);
			row.appendChild(column)
		}
	}
	outTable.appendChild(row);

}
