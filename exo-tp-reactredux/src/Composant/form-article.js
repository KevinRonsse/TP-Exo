import Component from 'react';
import {addToArticle}'../'

export class FormArticles extends Component {
    constructor(props) {
        super(props);
        this.state = {
            article:{
                title:undefined,
                content:undefined
            }
        }
    }
    fieldsOnChange = (e)=>{
        const tpmArticle = this.state.annonce
        tpmArticle[e.target.getAttribute('name')] = e.target.value
        this.setState({annonce: {...tpmArticle}})
    }

    confirm = (e)=>{
        e.preventDefault()
        addToArticle({...this.state.article, status:false}).then(res => {
            if(res.data.error === false){
                this.props.navigate("/")

            }

            else{
                alert(this.data.message)
            }

        })
    }
}