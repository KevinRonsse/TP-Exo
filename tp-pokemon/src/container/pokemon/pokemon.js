import React from 'react'
import {useLocation} from 'react-router-dom'
import './pokemon.css'

export default function Pokemon() {
    const location = useLocation()

    return(
        <div className='pokemon-content'>
            <image src={location.state.urlImage}></image>
            <h2>Liste Pokemon : {location.state.id}</h2>
            <p>{location.state.name}</p>
        </div>
    )
}