const productsArray = [
    { productName: "Laptop", fullName: "HP Spectre x360", productId: "LP123", site: "Warehouse A" },
    { productName: "Smartphone", fullName: "iPhone 13", productId: "SP456", site: "Warehouse B" },
    { productName: "Headphones", fullName: "Sony WH-1000XM4", productId: "HP789", site: "Warehouse C" }
];

const productList = document.getElementById('productList');
const shiwaddProductInput = document.getElementById('addProduct_show');

const addProductButton = document.getElementById('addProductButton');

function saveThesitesData() {

    let jsstring = (JSON.stringify(products_Array));
    localStorage.setItem('product_Array', jsstring);
}

//saveThesitesData();

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

function getDeleteProduct(index) {

    //alert("delete funcionality")
    //console.log(index)

    if (confirm("Are you sure you want to delete this site?")) {

        products_Array.splice(index, 1);

        saveThesitesData();

        renderProducts(products_Array);

        console.log(products_Array.length);
    }
}

function getUpdateProduct(index) {

    const product = products_Array[index];

    const productRow = productList.children[index];

    let siteDropdown = `<select class="col" id="site">`;
    sites_Arrydata.forEach(site => {
        const isSelected = site.siteName === product.site ? "selected" : "";
        siteDropdown += `<option value="${site.siteName}" ${isSelected}>${site.siteName}</option>`;
    });
    siteDropdown += `</select>`;

    productRow.innerHTML = `
        <input class="col" value="${product.productName}" id="productName" />
        <input class="col" value="${product.fullName}" id="fullName" />
        <input class="col" value="${product.productId}" id="productId" />
        ${siteDropdown}
        <button type="button" class="col action-button" onclick="submitUpdatedProduct(${index})">Submit</button>
    `;

}



function submitUpdatedProduct(index) {

    const productRow = productList.children[index];
    const userInputs = productRow.querySelectorAll('input');

    const siteDropdown = productRow.querySelector('select');

  
    const updatedProduct = {
        productName: userInputs[0].value,
        fullName: userInputs[1].value,
        productId: userInputs[2].value,
        site: siteDropdown.value,
    };

    console.log(updatedProduct)

    products_Array[index] = updatedProduct;
  
    saveThesitesData();

    renderProducts(products_Array);
}



function siteDropdown() {

    const siteDropdown = document.getElementById('site');
   

    sites_Arrydata.forEach(site => {

        const option = document.createElement('option');
        option.value = site.siteName; 
        option.textContent = site.siteName;
        siteDropdown.appendChild(option);
    });
}


siteDropdown();

addProductButton.addEventListener('click', () => {

    if (shiwaddProductInput.style.display === "flex") {

        submitAddProduct(); 


    } else {
        shiwaddProductInput.style.display = "flex"; 
        addProductButton.textContent = "Submit";   
    }
});

function submitAddProduct() {
    const productName = document.getElementById('productName').value;
    const fullName = document.getElementById('fullName').value;
    const productId = document.getElementById('productId').value;
    const site = document.getElementById('site').value;

    if (productName && fullName && productId && site) {
        const newProduct = { productName, fullName, productId, site };

        productsArray.push(newProduct);

        products_Array.push(newProduct);

        saveThesitesData();

        renderProducts(products_Array);
        shiwaddProductInput.style.display = "none";
        addProductButton.textContent = "Add new Product";

        clearInputs();
    } else {
        alert("Please fill all the fields!");
    }
}


function renderProducts(products) {
    productList.innerHTML = '';  

    products.forEach( (product,index) => {
        const newRow = document.createElement('div');
        newRow.classList.add('row');
        newRow.innerHTML = `
            <div class="col">${product.productName}</div>
            <p class="col">${product.fullName}</p>
            <p class="col">${product.productId}</p>
            <p class="col">${product.site}</p>
            <p class="col">
            <button type="button" class="action-button" onclick="getDeleteProduct(${index})">Delete</button>
            <button type="button" class="action-button" id="updateSite" onclick="getUpdateProduct(${index})" value="Hi">Update</button>
            </p>
        `;
        productList.appendChild(newRow);
    });
}


function clearInputs() {
    document.getElementById('productName').value = '';
    document.getElementById('fullName').value = '';
    document.getElementById('productId').value = '';
    document.getElementById('site').value = '';
}


function delSite() {
    alert("del")
   
        products_Array.pop(); // remove from array

        saveThesitesData();

        renderSites(products_Array); 
    
}


function searchProducts() {

    const searchTerm = document.getElementById('searchInput').value.toLowerCase();

    const filteredProducts = products_Array.filter(product =>
        product.productName.toLowerCase().includes(searchTerm) ||
        product.fullName.toLowerCase().includes(searchTerm) ||
        product.productId.toLowerCase().includes(searchTerm) ||
        product.site.toLowerCase().includes(searchTerm)
    );
    renderProducts(filteredProducts);
}


renderProducts(products_Array);


document.getElementById('searchInput').addEventListener('keyup', searchProducts);
