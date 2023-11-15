const getAllCartegories = async () => {
    try {
        const res = await fetch("api/Categorys")
        const Categories = await res.json();
        return Categories;
    }
    catch (ex) {
        console.log(ex);
    }
}



//const getAllProducts = async (categories, minPrice, maxPrice, desc) => {
//    try {
//        var url = "/api/Prodact"
//        const res = await fetch("api/Prodact?position=1&skip=8")
//        const products = await res.json();
//        return products;
//    }
//    catch (ex) {
//        console.log(ex);
//    }
//}

const getAllProducts = async (categoryIds, minPrice, maxPrice, desc) => {

    try {
        let url = `/api/Prodact`;
        if (desc || minPrice || maxPrice || categoryIds)
            url += `?`
        if (desc) url += `desc=${desc}`;
        if (minPrice) url += `&minPrice=${minPrice}`;
        if (maxPrice) url += `&maxPrice=${maxPrice}`;
        if (categoryIds) {
            for (let i = 0; i < categoryIds.length; i++) {
                url += `&categoryIds=${categoryIds[i]}`
            }
        }
        if (url == '/api/Prodact') {
            url += `?position=1&skip=8`
        }
        else {
            url += `&position=1&skip=8`

        }
        console.log(url)
        const res = await fetch(url)

        if (!res.ok)
            window.alert("NotFound")
        else {

            let productArray = await res.json()
            showProduct(productArray);
        }
    }

    catch (e) {
        console.log(e);
    }

}




const showCategories = async () => {
    const Categories = await getAllCartegories();
    for (let i = 0; i < Categories.length; i++) {
        console.log(Categories)
        var tmpCatg = document.getElementById("temp-category");
        var cln = tmpCatg.content.cloneNode(true);
        cln.querySelector("label").for = Categories[i].categoryName;
        cln.querySelector("input").value = Categories[i].categoryName;
        cln.querySelector("input").id = Categories[i].categoryId;
        cln.querySelector("img").src = "./categoryImg/" + Categories[i].img
        cln.querySelector("span.OptionName").innerText = Categories[i].categoryName;
        document.getElementById("categoryList").appendChild(cln);
    }


}
const showProduct = async (product) => {
    for (let i = 0; i < product.length; i++) {
        console.log(product)
        var tmpProduct = document.getElementById("temp-card");
        var cln = tmpProduct.content.cloneNode(true);
        cln.querySelector("img").src = "./cars/" + product[i].img;
        cln.querySelector("h1").innerText = product[i].productName;
        cln.querySelector(".price").innerText = product[i].price + 'ש"ח';
        cln.querySelector(".description").innerText = product[i].productDescription;
        //  cln.querySelector("button").addEventListener("click", {addToCard(product[i])})
        document.getElementById("PoductList").appendChild(cln);
    }
}




    const filterProduct = async ()=> {
        var categories = [];
        const options = document.querySelectorAll(".opt")
        for (let i = 0; i < options.length; i++) {
            if (options[i].checked) {
                categories.push(options[i].id)
            }
        }

            const minPrice = document.getElementById("minPrice").value
            const maxPrice = document.getElementById("maxPrice").value
            const desc = document.getElementById("nameSearch").value
            document.getElementById("PoductList").replaceChildren([]);

            getAllProducts(categories, minPrice, maxPrice, desc)

       
    }
   




