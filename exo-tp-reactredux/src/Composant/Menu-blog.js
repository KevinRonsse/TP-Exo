import { Link } from "react-router-dom"

export const MenuBlog = (props) => {
    return (
        <header>
            <nav>
            <Link to="/">Accueil</Link>
            <Link to="/formulaire">Creer un article</Link>
            <Link to="/">Contact</Link>
            </nav>
        </header>
    )
}