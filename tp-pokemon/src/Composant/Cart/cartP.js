import {React} from 'react'
import './cartpokemon.css'

export function CartPokemon(props) {
    return (
        <div className="card">
            {props.children}
        </div>
    )
}
