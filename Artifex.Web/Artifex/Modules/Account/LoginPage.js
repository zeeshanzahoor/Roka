import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import store from '../../core/store/store';
import { ArtifexComponent } from '../Components/Artifex';
import { UserConstants } from '../../core/constants';
import { Icon } from '@material-ui/core/';
import { AccountCircle } from '@material-ui/icons/';


import PropTypes from 'prop-types';

import {
    TextField, FormControl, InputLabel, Input, Button, CardMedia, CardActions, CardContent, Card,
    Typography, Avatar, Grid, Paper
} from '@material-ui/core';

import { ValidatorForm, TextValidator } from 'react-material-ui-form-validator';


class LoginPage extends ArtifexComponent {
    constructor(props) {
        super(props);
        this.state = {
            username: 'zeeshan.zahoor',
            password: '123',
            submitted: false
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.handleBlur = this.handleBlur.bind(this);
    }
    handleBlur(event) {
        this.refs[event.target.name].validate(event.target.value);
    }
    handleChange(e) {
        const { name, value } = e.target;
        this.setState({[name]: value });
    }

    handleSubmit(e) {
        e.preventDefault();
        this.setState({ submitted: true });
        const { username, password } = this.state;
        const { dispatch } = this.props;
        if (username && password) {
            dispatch(this.Login(username, password));
        }
    }

    Login(username, password) {
        return dispatch => {
            dispatch(request({ username }));
            var data = { username, password };

            this.POST('/Authenticate/login', data)
                .then((result) => {
                    if (result.success) {
                        dispatch(success(result.data.user));
                    }
                });
        };

        function request(user) { return { type: UserConstants.LOGIN_REQUEST, user } }
        function success(user) { return { type: UserConstants.LOGIN_SUCCESS, user } }
        function failure(error) { return { type: UserConstants.LOGIN_FAILURE, error } }
    }

    render() {
        const { loggingIn } = this.props;
        const { username, password, submitted } = this.state;
        return (
            <main role="main" className='login-screen'>
                <div className="login-screen-inner">
                    <div className="container-fluid">
                        <div className="row content">
                            <div className="" >
                                <Card className="no-radius login-wrapper">
                                    <CardContent className="login-card-content">
                                        <Typography margin="normal" align="center" variant="headline">
                                            <AccountCircle color="primary" style={{ fontSize: 76, marginTop: 10, }}>
                                            </AccountCircle>
                                        </Typography>

                                        <ValidatorForm
                                            ref="form"
                                            instantValidate={false}
                                            style={{ marginTop: 20 }}
                                            onSubmit={this.handleSubmit} >

                                            <TextValidator
                                                label="User Name/Email"
                                                ref="username"
                                                onChange={this.handleChange}
                                                name="username"
                                                fullWidth
                                                onBlur={this.handleBlur}
                                                value={username}
                                                autoComplete="off"
                                                validators={['required']}
                                                errorMessages={['this field is required']}
                                            />
                                            <br />
                                            <br />
                                            <TextValidator
                                                label="Password"
                                                ref="password"
                                                onChange={this.handleChange}
                                                name="password"
                                                onBlur={this.handleBlur}
                                                value={password}
                                                fullWidth
                                                autoComplete="off"
                                                validators={['required', 'minStringLength:1']}
                                                errorMessages={['this field is required', 'this field is required']}
                                            />
                                            <br />
                                            <br />
                                            <Button
                                                fullWidth
                                                style={{ marginTop: 30, }}
                                                type="submit"
                                                variant="contained" color="primary" className="no-radius">
                                                <label>
                                                    Login
                                                </label>
                                            </Button>
                                        </ValidatorForm>



                                    </CardContent>
                                </Card>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        );
    }
}

function mapStateToProps(state) {
    return state;
}

const connectedLoginPage = connect(mapStateToProps)(LoginPage);
export { connectedLoginPage as LoginPage }; 