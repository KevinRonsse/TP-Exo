import { withRouter } from "../hoc/withrouter"
import { BtnProduit } from "./boutonduproduit"

export const ProduitDetail = withRouter((props) => {
    const id = props.params.id
    const produit = props.findProduit(id)
    return (
        <div>{
            produit === undefined ?
                (
                    <div>
                        aucun produit avec cet id
                    </div>
                )
                :
                (
                    <div>
                        Detail produit
                        {produit.title}<br />
                        {produit.price}<br />
                        <BtnProduit id={id} removeFromCart={props.removeFromCart} addToCart={props.addToCart} isInCart={props.isInCart}></BtnProduit>
                    </div>
                )
        }
        </div>
    )
})