import React, { useState, useEffect } from "react";
import "./navbar.css"
import { Link } from "react-router-dom";

export default function Navbar() {
    const [toggleMenu, setToggleMenu] = useState(false);
    const [largeur, setLargeur] = useState(window.innerWidth);

    const toggleNav = () => {
        setToggleMenu(!toggleMenu);
    };

    useEffect(() => {
        const changeWidth = () => {
         setLargeur(window.innerWidth)
        };

        window.addEventListener("resize",changeWidth);
        return()=>{
            window.removeEventListener("resize",changeWidth);
        };
    },[]);

    return(
        <nav>
            {(toggleMenu||largeur > 500) &&(
                <ul className="liste">
                <li className="item">
                <Link to="/">Home</Link>
                </li>
                <li className="item">
                    <Link to="/ecrire">Mon Pokedex</Link>
                </li>
                <li className="item">
                    <Link to="/ecrire">Pokebal</Link>
                </li>
                </ul>
            )}
                <button onClick={toggleNav} className="btn">Clear</button>
                <button onClick={toggleNav} className="btn">Show</button>
                
        </nav>
    );
}