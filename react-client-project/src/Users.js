import React, { Component } from "react";
import axios from "axios";

export default class Users extends Component {

    constructor(props) {
        super(props);
        this.state = {
            users: []
        };
    }

    componentDidMount() {
        axios.get("http://localhost:24499/api/users")
            .then(res => {
                this.setState({ users: res.data });
                console.log(this.state.users);
            })
            .catch(error => {
                console.log(error);
            })
    }

    render() {
        return (
            <div>
                <h2>User List</h2>
            </div>
        );
    }

}