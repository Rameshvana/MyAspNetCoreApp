
const showAddsiteInput = document.getElementById('addSite_show');

const addSiteButton = document.getElementById("addSiteButton");

const siteList = document.getElementById('siteList');

const updateSiteBtn = document.getElementById("updateSite");



//function showAddSite() {
//    if (showAddsiteInput.style.display === "flex") {

//        showAddsiteInput.style.display = "none";

//    } else {
//        showAddsiteInput.style.display = "flex";
//    }
//}



addSiteButton.addEventListener('click', () => {
    if (showAddsiteInput.style.display === "flex") {

        submitSite(); 


    } else {
        showAddsiteInput.style.display = "flex"; 
        addSiteButton.textContent = "Submit";  
    }
});

const sitesArray = [
    { siteName: "W3 School", description: "Learning Portal", address: "Internet", sitecode: "988434", sitetype: "Courses" },
    { siteName: "MDN Web Docs", description: "Web Development", address: "Online", sitecode: "123456", sitetype: "Documentation" },
    { siteName: "Codecademy", description: "Interactive Learning", address: "Internet", sitecode: "789012", sitetype: "Courses" },
    { siteName: "freeCodeCamp", description: "Coding Challenges", address: "Online", sitecode: "345678", sitetype: "Practice" },
    { siteName: "Khan Academy", description: "Free Education", address: "Internet", sitecode: "901234", sitetype: "Courses" }
];
   
function saveThesitesData() {

    let jsstring = (JSON.stringify(sites_Array));
    localStorage.setItem('sitesArray', jsstring);
}

//saveThesitesData();

function getTheSites() {

    let getitem = localStorage.getItem('sitesArray');
    let convert = (JSON.parse(getitem));
    if (getitem === null) {
        return [];
    } else {
        return convert;
    }
}

const sites_Array = getTheSites();

console.log(sites_Array);



 
renderSites(sites_Array);

  

function submitSite() {
    
        const siteName = document.getElementById('siteName').value;
        const description = document.getElementById('description').value;
        const address = document.getElementById('address').value;
        const sitecode = document.getElementById('sitecode').value;
        const sitetype = document.getElementById('sitetype').value;

        if (siteName && description && address && sitecode && sitetype) {
            const newSite = {
                siteName,
                description,
                address,
                sitecode,
                sitetype
            };
            sitesArray.push(newSite);

            sites_Array.push(newSite);

            saveThesitesData();

            renderSites(sites_Array);

            showAddsiteInput.style.display = "none";
            addSiteButton.textContent = "Add new Site";

            clearInputs();
        } else {
            alert("Please fill all the fields...");
        }
    }
function getDeleteSite(index) {

    //alert("delete funcionality")
    //console.log(index)

    if (confirm("Are you sure you want to delete this site?")) {

        sites_Array.splice(index, 1);  

        saveThesitesData();
        
        renderSites(sites_Array);   
    }
}



function getUpdateSite(index) {

    let site = sites_Array[index];

    console.log(site);

    //<div class="row user" id="addSite_show" style="display: none;">
    //    <input class="col" id="siteName" value="" placeholder="siteName" />
    //    <input class="col" id="description" value="" placeholder="description" />
    //    <input class="col" id="address" value="" placeholder="address" />
    //    <input class="col" id="sitecode" value="" placeholder="siteCode" />
    //    <input class="col" id="sitetype" value="" placeholder="siteType" />
    //</div>

    const siteRow = siteList.children[index];

   
    siteRow.innerHTML = `
        <input class="col" value="${site.siteName}" id="siteName" />
        <input class="col" value="${site.description}" id="description"/>
        <input class="col" value="${site.address}" id="address"/>
        <input class="col" value="${site.sitecode}" id="sitecode"/>
        <input class="col" value="${site.sitetype}" id="sitetype"/>
        <button type="button" class="col action-button" onclick="submitUpdatedSite(${index})">Submit</button>
    `;
    
}

function submitUpdatedSite(index) {

    alert("submit box");

    const siteRow = siteList.children[index];

    const User_inputs = siteRow.querySelectorAll('input');

  
    const updatedSite = {
        siteName: User_inputs[0].value,
        description: User_inputs[1].value,
        address: User_inputs[2].value,
        sitecode: User_inputs[3].value,
        sitetype: User_inputs[4].value
    };

    console.log(updatedSite);

    sites_Array[index] = updatedSite;
    saveThesitesData();

    renderSites(sites_Array)

}





function renderSites(sites) {
    siteList.innerHTML = '';
    sites.forEach( (site,index) => {
        const newRow = document.createElement('div');
        newRow.classList.add('row');
        newRow.innerHTML = `
            <div class="col">${site.siteName}</div>
            <p class="col">${site.description}</p>
            <p class="col">${site.address}</p>
            <p class="col">${site.sitecode}</p>
            <p class="col">${site.sitetype}</p>
            <p class="col">
            <button type="button" class="action-button" onclick="getDeleteSite(${index})">Delete</button>
            <button type="button" class="action-button" id="updateSite" onclick="getUpdateSite(${index})" value="Hi">Update</button>
            </p>
        `;
        siteList.appendChild(newRow);
    });
}

function delSite() {
    alert("del")
   
        sites_Array.pop(); // Remove from array

        saveThesitesData();

        renderSites(sites_Array); 
    
}

    
function clearInputs() {
        document.getElementById('siteName').value = '';
        document.getElementById('description').value = '';
        document.getElementById('address').value = '';
        document.getElementById('sitecode').value = '';
        document.getElementById('sitetype').value = '';
}


searchInput.addEventListener('keyup', searchSite);
function searchSite() {

    const searchTerm = searchInput.value.toLowerCase();
    const filteredSites = sites_Array.filter(site =>
        site.siteName.toLowerCase().includes(searchTerm) ||
        site.description.toLowerCase().includes(searchTerm) ||
        site.address.toLowerCase().includes(searchTerm)
    );
    renderSites(filteredSites);
}




   
    
   


