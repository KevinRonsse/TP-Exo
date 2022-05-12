import { Component } from 'react'
import { ListeProduit } from "./listeproduit"
import { CardCount } from "./cartcount"
import {BrowserRouter} from "react-router-dom"
import{MenuProduit}from "./menuproduit"
import {ProduitRouter} from "./produitrouter"


export class AppProduit extends Component {
    constructor(props) {
        super(props)
        this.state = {
            produits: [
                { id: 1, title: 'assassin creed collection', urlImage: 'https://static.fnac-static.com/multimedia/Images/FR/NR/8f/74/5f/6255759/1540-1/tsp20141016153913/Pack-4-Jeux-Aain-s-Creed-PC.jpg', price: 5 },
                { id: 2, title: 'assassin creed Valhalla', urlImage: 'https://static.fnac-static.com/multimedia/Images/FR/NR/bd/8b/aa/11176893/1505-1/tsp20201221123345/Aain-s-Creed-Valhalla-PS4.jpg', price: 20 },
            ],
            cart: []

        }
    }

    findProduit =(id) => {
        return this.state.produits.find(p=> p.id === id)
    }

    addToCart = (id) => {
        const produit = this.state.produits.find(p => p.id === id)
        if (produit !== undefined)
            this.setState({ cart: [...this.state.cart, { ...produit }]})
    }

    isInCart = (id) => {
        return this.state.cart.find(p => p.id === id) !== undefined
    }
    removeFromCart = (id) => {
        const newCart = this.state.cart.filter(p => p.id !== id)
        this.setState({ cart: [...newCart] });
    }
    render() {
        return (
            <div>
               <BrowserRouter>
               <MenuProduit totalProduit={this.state.cart.length}></MenuProduit>
               <ProduitRouter cart={this.state.cart} produits={this.state.produits} removeFromCart={this.removeFromCart}addToCart={this.addToCart} findProduit={this.findProduit} isInCart={this.isInCart}></ProduitRouter>
               </BrowserRouter>
            </div>

        );
    }
}
