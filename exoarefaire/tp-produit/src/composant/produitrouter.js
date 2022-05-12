import {Route, Routes}from"react-router-dom"
import {Cart} from "./cart"
import { ListeProduit } from "./listeproduit"
import { ProduitDetail } from "./produitdetail"


export const ProduitRouter = (props) => {
    return(
        <Routes>
            <Route path='/' element={<ListeProduit produits={props.produits} removeFromCart={props.removeFromCart}></ListeProduit>}></Route>
            <Route path="/cart" element={<Cart cart={props.cart} removeFromCart={props.removeFrom} isInCart={props.isInCart} />}></Route>
            <Route path="/produit/:id" element={<ProduitDetail findProduit={props.findProduit} removeFromCart={props.removeFromCart} addToCart={props.addToCart} isInCart={props.isInCart} />}></Route>
        </Routes>
    )
}