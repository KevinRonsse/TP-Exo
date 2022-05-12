/* eslint-disable jsx-a11y/alt-text */
/*import { BtnProduit } from "./boutonduproduit";*/
import { Link } from "react-router-dom"
import { withRouter } from "../hoc/withrouter"

export const Produit = withRouter ((props) => {
    const { urlImage, title, price, id } = props.Produit;
    return (
        <div>
            <div><img src={urlImage}></img></div>
            <div>{title}</div>
            <div>{price} €</div>
           {/* <BtnProduit id={id} isInCart={props.isInCart} removeFromCart={props.removeFromCart} addToCart={props.addToCart}></BtnProduit> */}
           <Link to={"/produit/"+id}>Detail</Link>
            {/*BtnProduit < {...props}></BtnProduit> */}
        </div>
    )
})