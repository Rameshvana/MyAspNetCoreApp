const usersArray = [
    { userName: "john_doe", fullName: "John Doe", description: "Admin User", email: "john@example.com", password: "123456", site: "Warehouse A", product: "Laptop" },
    { userName: "jane_smith", fullName: "Jane Smith", description: "Manager", email: "jane@example.com", password: "abcdef", site: "Warehouse B", product: "Smartphone" }
];

const userList = document.getElementById('userList');
const addUserInput = document.getElementById('addUser_show');
const addUserButton = document.getElementById("addUserButton");

const siteDropdown = document.getElementById('siteSelect');
const productDropdown = document.getElementById("productSelect");


siteDropdown.addEventListener("change", function (event) {

    //productDropdown.removeChild(option);

    const selectedSite = this.value;

    console.log(selectedSite);

    const filteredProducts = products_Array.filter(product => product.site === selectedSite);

    console.log(filteredProducts);
    

    filteredProducts.forEach(site => {
        const option = document.createElement('option');

        option.value = site.productName; 
        option.textContent = site.productName;

        productDropdown.appendChild(option);
       
    })
})

addUserButton.addEventListener('click', () => {

    if (addUserInput.style.display === "flex") {

        submitAddUser(); // Submit if form is visible


    } else {
        addUserInput.style.display = "flex"; // Show form if hidden
        addUserButton.textContent = "Submit";   // Change button to Submit
    }
});

function getTheSites(value) {

    let getitem = localStorage.getItem(value);
    let convert = (JSON.parse(getitem));
    if (getitem === null) {
        return [];
    } else {
        return convert;
    }
}

const products_Array = getTheSites("product_Array");
console.log(products_Array);


const sites_Arrydata = getTheSites("sitesArray");
console.log(sites_Arrydata)

function saveThesitesData() {

    let jsstring = (JSON.stringify(users_Array));
    localStorage.setItem('users_Array', jsstring);
}

const users_Array = getTheSites("users_Array");
console.log(users_Array)



function populateSiteDropdown() {

        sites_Arrydata.forEach(site => {
        const option = document.createElement('option');
        option.value = site.siteName; // Using siteName as value
        option.textContent = site.siteName; // Display name
        siteDropdown.appendChild(option);
    });
}

function getDeleteUser(index) {

    if (confirm("Are you sure you want to delete this user?")) {

        users_Array.splice(index, 1);

        saveThesitesData();

        renderUsers(users_Array);
    }
}


function getUpdateUser(index) {

  

    const user = users_Array[index];

    const userRow = userList.children[index];

    
    let siteDropdown = `<select class="col" id="siteSelect">`;
    sites_Arrydata.forEach(site => {
        const isSelected = site.siteName === user.site ? "selected" : "";
        siteDropdown += `<option value="${site.siteName}" ${isSelected}>${site.siteName}</option>`;
    });
    siteDropdown += `</select>`;

    
    let productDropdown = `<select class="col" id="productSelect">`;
    const filteredProducts = products_Array.filter(product => product.site === user.site);

    filteredProducts.forEach(product => {
        const isSelected = product.productName === user.product ? "selected" : "";
        productDropdown += `<option value="${product.productName}" ${isSelected}>${product.productName}</option>`;
    });
    productDropdown += `</select>`;

    // Update user row with input fields
    userRow.innerHTML = `
        <input class="col" value="${user.userName}" id="userName" />
        <input class="col" value="${user.fullName}" id="fullName" />
        <input class="col" value="${user.description}" id="description" />
        <input class="col" value="${user.email}" id="email" />
        <input class="col" value="${user.password}" id="password" />
        ${siteDropdown}
        ${productDropdown}
        <button type="button" class="col action-button" onclick="submitUpdatedUser(${index})">Submit</button>
    `;
}



function submitUpdatedUser(index) {

    const userRow = userList.children[index];

    const userInputs = userRow.querySelectorAll('input');
    const siteSelect = userRow.querySelector('#siteSelect');
    const productSelect = userRow.querySelector('#productSelect');

    const updatedUser = {
        userName: userInputs[0].value,
        fullName: userInputs[1].value,
        description: userInputs[2].value,
        email: userInputs[3].value,
        password: userInputs[4].value,
        site: siteSelect ? siteSelect.value : '',      // Check if siteSelect exists
        product: productSelect ? productSelect.value : ''
    };
    users_Array[index] = updatedUser;

    
    saveThesitesData();

  
    renderUsers(users_Array);
}

populateSiteDropdown();


function submitAddUser() {
    const userName = document.getElementById('userName').value;
    const fullName = document.getElementById('fullName').value;
    const description = document.getElementById('description').value;
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;
    const site = document.getElementById('siteSelect').value;
    const product = document.getElementById('productSelect').value;

    if (userName && fullName && description && email && password && site && product) {

        const newUser = { userName, fullName, description, email, password, site, product };

        usersArray.push(newUser);

        users_Array.push(newUser);

        saveThesitesData();
        renderUsers(users_Array);
        clearInputs();

        addUserInput.style.display = "none";
        addUserButton.textContent = "Add new User";
    } else {
        alert("Please fill all the fields!");
    }
}

function renderUsers(users) {
    userList.innerHTML = '';
    users.forEach( (user,index) => {
        const newRow = document.createElement('div');
        newRow.classList.add('row');
        newRow.innerHTML = `
            <div class="col">${user.userName}</div>
            <p class="col">${user.fullName}</p>
            <p class="col">${user.description}</p>
            <p class="col">${user.email}</p>
            <p class="col">${'*'.repeat(user.password.length)}</p>

            <p class="col">${user.site}</p>
            <p class="col">${user.product}</p>
            <p class="col">
                <button type="button" class="action-button" onclick="getDeleteUser(${index})">Delete</button>
                <button type="button" class="action-button" id="updateSite" onclick="getUpdateUser(${index})" value="Hi">Update</button>
            </p>
        `;
        userList.appendChild(newRow);
    });
}


function clearInputs() {

    document.getElementById('userName').value = '';
    document.getElementById('fullName').value = '';
    document.getElementById('description').value = '';
    document.getElementById('email').value = '';
    document.getElementById('password').value = '';
    document.getElementById('siteSelect').value = '';
    document.getElementById('productSelect').value = '';
}


function searchUsers() {
    const searchTerm = document.getElementById('searchInput').value.toLowerCase();
    const filteredUsers = users_Array.filter(user =>
        user.userName.toLowerCase().includes(searchTerm) ||
        user.fullName.toLowerCase().includes(searchTerm) ||
        user.email.toLowerCase().includes(searchTerm) ||
        user.site.toLowerCase().includes(searchTerm) ||
        user.product.toLowerCase().includes(searchTerm)
    );
    renderUsers(filteredUsers);
}


renderUsers(users_Array);


document.getElementById('searchInput').addEventListener('keyup', searchUsers);
