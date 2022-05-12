import {withRouter} from '../hoc/with-router'
import {DBtn} from "./detail-button"

export const DetailArticle = withRouter((props) => {
    const id = props.params.id
    const annonce = props.findAnnonce(id)
    return(
        <div>
            {
                annonce === undefined ?
                (
                    <div>
                        aucun article avec cet id
                    </div>

                )
                :
                (
                    <div>
                        detail article
                        {annonce.title}
                        {annonce.content}
                        <DBtn id={id} addToArticle={props.addToArticle}></DBtn>
                    </div>
                )
            }
        </div>
    )

})