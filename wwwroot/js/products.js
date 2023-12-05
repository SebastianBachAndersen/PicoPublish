const path = 'api/product';
let offset = 0;
let pages = 10;
let desc = false;

function getItems(status = 'current') {
    if (status === 'next') {
        offset = offset + pages;
    }
    if (status === 'prev') {
        if (offset === 0) {
            return;
        }
        offset = offset - 10;
    }
    
    fetch(path + `?offset=${offset}&pages=${pages}${desc ? '&desc=true' : ''}`)
        .then((response) => response.json())
        .then((items) => displayProducts(items)) 
    
}


function displayProducts(items) {
    const table = document.getElementById('products') 
    table.innerHTML = '';
    
    items.forEach((item) => {
        let id = document.createElement('p');
        id.appendChild(document.createTextNode(item.id))


        let name = document.createElement('p');
        name.appendChild(document.createTextNode(item.name))


        let description= document.createElement('p');
        description.appendChild(document.createTextNode(item.description))
        
        let tr = table.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(id);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(item.name);
        td2.appendChild(name);

        let td3 = tr.insertCell(2);
        td3.appendChild(description);
        
        let edit = tr.insertCell(3);
        let editButton = document.createElement('a');
        editButton.href=`edit.html?id=${item.id}&name=${item.name}&description=${item.description}`;
        editButton.innerHTML = 'rediger';
        edit.appendChild(editButton);
        
        let deleteRow = tr.insertCell(4);
        let deleteButton = document.createElement('button');
        deleteButton.innerHTML = 'slet';
        deleteButton.onclick = () => deleteProduct(item.id);
        deleteRow.appendChild(deleteButton);
        

    })
}

function deleteProduct(id) {

    if (!confirm('Er du sikker på at du vil slette produktet?')) {
        return;
    }

    fetch(`${path}/${id}`, {
        method: "delete",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
    })
    .then(() => {
        getItems();
    })
}

function insertProduct() {
    const name = document.getElementById('name')
    const description = document.getElementById('description')
    
    fetch(path, {
        method: "put",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }, 
        body: JSON.stringify({
            name: name.value.trim(),
            description: description.value.trim()
        }),
    })
        .then((response) => response.json())
        .then((res) => {
            console.log(res)
            name.value = '';
            description.value = '';
        })
    
}

function populateEditModal() {
    const formElement = document.getElementById('edit-form');
    const urlSearchParams = new URLSearchParams(window.location.search);
     urlSearchParams.forEach((val, key) => {
        const elem = document.createElement('input');
        elem.value = val;
        elem.id = `product-${key}`;
        elem.type = 'text';
        
        formElement.appendChild(elem);
    });
    
    const saveButton = document.createElement('input');
    saveButton.type = 'submit';
    saveButton.value = 'Gem';
    formElement.appendChild(saveButton);
}

function editProduct() {

   const id = document.getElementById('product-id')
    const name = document.getElementById('product-name')
    const description = document.getElementById('product-description')
    
    
    fetch(`${path}/${id.value.trim()}`, {
        method: "patch",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            name: name.value.trim(),
            description: description.value.trim()
        }),
    })
        .then(() => {
            alert('Product saved')
        })
}

function setOrder(descending= false) {
    if (descending === desc) {
        return;
    }
    desc = descending;
    offset = 0;
    pages = 10;
    getItems();
}