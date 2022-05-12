import { Produit } from "./produit"

export const ListeProduit= (props) => {
    return(
        <div>
            {props.produits.map((p,i) => (<Produit Produit={p} key={i} isInCart={props.isInCart}  removeFromCart={props.removeFromCart} addToCart={props.addToCart} ></Produit>))}
        </div>
    )
    
}