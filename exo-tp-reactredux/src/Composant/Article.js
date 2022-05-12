import { Link } from "react-router-dom"
import {withRouter} from "../hoc/with-router"

export const Article = withRouter ((props) => {
    const {id,title,content} = props.article
    return (
        <div>
            <div>{id}</div>
            <div>{title}</div>
            <div>{content}</div>
           <Link to={"/annonce/"+id}>Detail article</Link>
        </div>
    )
})