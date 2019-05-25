import React, { Component } from "react";
import { withArtifex, ArtifexGrid, ArtifexComponent, ArtifexLoadingPanel } from 'Artifex/Modules/Components/Artifex';
import { Grid, Card, Avatar, CardHeader, IconButton, CardContent, Typography, CardActions, Button } from '@material-ui/core';
import { MoreVert, Favorite, Share } from '@material-ui/icons';

import { ArtifexForm, ArtifexText, ArtifexButton } from 'Artifex/Modules/Components/Form'
import { TextValidator, ValidatorForm } from 'react-material-ui-form-validator';




class FormTest extends ArtifexComponent {
    constructor(props) {
        super(props);
        this.state = {
            model: {
                username: 'Zeeshan',
                firstname: '',
                lastname: '',
                address:''
            },
            loadingMyContent:true,
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleSubmit(e) {
        this.setState({ loading: "loading" });
    }
    handleChange(e) {
        const { name, value } = e.target;
        this.state.model[name] = value;
        this.setState({
            model: this.state.model,
        });
    }
    render() {
        return (
            <Grid container spacing={16}>
                <Grid item md={6} xs={12}>
                    <Card className="no-radius">

                        <ArtifexForm ref="form"  onSubmit={this.handleSubmit}>
                            <CardHeader
                                title="Here is a sample form" />
                            <CardContent className="no-padding-top">

                                <ArtifexText
                                    label="Email"
                                    name="username"
                                    className="form-input"
                                    onChange={this.handleChange}
                                    model={this.state.model}
                                    validators={['required']}
                                    errorMessages={['this field is required']} />

                                <ArtifexText
                                    label="First Name"
                                    name="firstname"
                                    className="form-input"
                                    onChange={this.handleChange}
                                    model={this.state.model}
                                    validators={['required']}
                                    errorMessages={['this field is required']} />

                                <ArtifexText
                                    label="Last Name"
                                    name="lastname"
                                    className="form-input"
                                    onChange={this.handleChange}
                                    model={this.state.model}
                                    validators={['required']}
                                    errorMessages={['this field is required']} />

                                <ArtifexText
                                    label="Address"
                                    name="address"
                                    className="form-input"
                                    onChange={this.handleChange}
                                    model={this.state.model}
                                    validators={['required']}
                                    errorMessages={['this field is required']} />

                                <div className="form-actions align-items-right">
                                    <ArtifexButton loading={this.state.loading} variant="contained" className="no-radius">
                                        Submit
                                    </ArtifexButton>
                                </div>

                            </CardContent>
                        </ArtifexForm>

                    </Card>
                </Grid>

                <Grid item md={6} xs={12}>
                    <Card className="no-radius">
                        <CardHeader
                            action={
                                <IconButton>
                                    <MoreVert />
                                </IconButton>
                            }
                            title="Shrimp and Chorizo Paella"
                            subheader="September 14, 2016"
                        />

                        <ArtifexLoadingPanel loadingHeight={200} loading={this.state.loadingMyContent}>
                            <CardContent>
                                <Typography paragraph variant="body2">
                                    Method:
                            </Typography>

                            <Typography paragraph>
                                Add rice and stir very gently to distribute. Top with artichokes and peppers, and
                                cook without stirring, until most of the liquid is absorbed, 15 to 18 minutes.
                                Reduce heat to medium-low, add reserved shrimp and mussels, tucking them down into
                                the rice, and cook again without stirring, until mussels have opened and rice is
                                just tender, 5 to 7 minutes more. (Discard any mussels that don’t open.)
                            </Typography>

                            </CardContent>
                        </ArtifexLoadingPanel>

                        <CardActions disableActionSpacing>
                            <IconButton aria-label="Add to favorites" color="primary" onClick={() => { this.setState({ loadingMyContent: !this.state.loadingMyContent }) }}>
                                <Favorite />
                            </IconButton>
                            <IconButton aria-label="Share" color="primary">
                                <Share />
                            </IconButton>
                        </CardActions>
                    </Card>
                </Grid>


                <Grid item md={6} xs={12}>
                    <Card className="no-radius">
                        <CardHeader
                            action={
                                <IconButton>
                                    <MoreVert />
                                </IconButton>
                            }
                            title="Shrimp and Chorizo Paella"
                            subheader="September 14, 2016"
                        />
                        <CardContent>
                            <Typography component="p">
                                This impressive paella is a perfect party dish and a fun meal to cook together with
                                your guests. Add 1 cup of frozen peas along with the mussels, if you like.
                             </Typography>
                            <Typography paragraph variant="body2">
                                Method:
                            </Typography>

                            <Typography paragraph>
                                Add rice and stir very gently to distribute. Top with artichokes and peppers, and
                                cook without stirring, until most of the liquid is absorbed, 15 to 18 minutes.
                                Reduce heat to medium-low, add reserved shrimp and mussels, tucking them down into
                                the rice, and cook again without stirring, until mussels have opened and rice is
                                just tender, 5 to 7 minutes more. (Discard any mussels that don’t open.)
                            </Typography>
                            <Typography>
                                Set aside off of the heat to let rest for 10 minutes, and then serve.
                            </Typography>
                        </CardContent>

                        <CardActions disableActionSpacing>
                            <IconButton aria-label="Add to favorites" color="primary">
                                <Favorite />
                            </IconButton>
                            <IconButton aria-label="Share" color="primary">
                                <Share />
                            </IconButton>
                        </CardActions>
                    </Card>
                </Grid>

            </Grid>
        );
    }
}
FormTest = withArtifex(FormTest);
export { FormTest };