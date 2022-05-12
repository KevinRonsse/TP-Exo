import {BtnProduit}from "./boutonduproduit"
export const Cart = (props) => {
    let total = 0
    props.cart.map(p => total += p.price)

    return (
        <div>
            <h1>panier</h1>
            {props.cart.map((p, i) =>
            (
                <div key={i}>{p.title}<BtnProduit id={p.id} removeFromCart={props.removeFromCart} addToCart={props.addToCart} isInCart={props.isInCart}></BtnProduit></div>
            )
            )}
            <div>{total}€</div>
        </div>
    )
}