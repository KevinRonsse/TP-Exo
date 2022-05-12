import {Link} from 'react-router-dom'
import { CardCount } from './cartcount'

export const MenuProduit = (props) => {
    return(
        <div>
            <Link to="/">Accueil</Link>
            <Link to="cart">Panier</Link>
            <CardCount totalProduit={props.totalProduit}></CardCount>
        </div>
    )
}