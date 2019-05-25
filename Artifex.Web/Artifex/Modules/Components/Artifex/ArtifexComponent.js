import React, { Component } from 'react';


class ArtifexComponent extends Component {
    constructor(props) {
        super(props);
        console.log(this.props);
    }
    POST(URL, Data) {
        var headers = {
            method: "POST",
            headers: {
                'Content-Type': 'application/json; charset=utf-8',
            },
            body: JSON.stringify(Data)
        };
        return fetch(URL, headers)
            .then((response) => {
                if (response.status == 403) {
                    UserContext.LogoutUser();
                    RNRestart.Restart();
                }
                else {
                    return response.json()
                }
            })
            .then((responseData) => {
                return responseData;
            })
            .catch((error) => {
                console.error(error);
            });
    }
}
export default ArtifexComponent;