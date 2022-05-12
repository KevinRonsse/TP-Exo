export const BtnProduit = (props) => {
    const { id, isInCart, removeFromCart, addToCart } = props

    const addToCartBtn = (e) => {
        if (!isInCart(id)) {
            addToCart(id)
        } else {
            removeFromCart(id)
        }
    }

    return (
        <div>
            <button onClick={addToCartBtn}>{isInCart(id) ? 'remove' : 'add'}</button>
        </div>
    )

}