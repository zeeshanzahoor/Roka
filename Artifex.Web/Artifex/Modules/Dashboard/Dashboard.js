import React, { Component } from "react";
import { RouteComponentProps } from "react-router";
import { withArtifex, ArtifexComponent } from 'Artifex/Modules/Components/Artifex';
import { Grid, Card, CardContent, CardActions, Typography, IconButton, CardHeader } from '@material-ui/core';
import { Favorite, Share } from '@material-ui/icons';
import Loadable from 'react-loadable';

const LoadableComponent = Loadable({
    loader: () => import('./Test'),
    loading: () => <div>Loading...</div>,
});


class Dashboard extends ArtifexComponent {
    render() {
        const { classes } = this.props;
        return (
            <Grid container spacing={16}>   
                <Grid item md={9} xs={12}>
                    <Card className="no-radius" >
                        <CardHeader
                            title="What happening today!"
                            subheader="sample form sub header" />
                        <CardContent>
                            <LoadableComponent/>
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
                <Grid item md={3} xs={12} >
                    <Card className="no-radius" style={{ height: 200 }}>
                    </Card>
                </Grid>
                <Grid item md={12} xs={12} >
                    <Card className="no-radius" style={{ height: 200 }}>
                    </Card>
                </Grid>

                <Grid item md={4} xs={12} >
                    <Card className="no-radius" style={{ height: 400 }}>
                    </Card>
                </Grid>
                <Grid item md={4} xs={12} >
                    <Card className="no-radius" style={{ height: 400 }}>
                    </Card>
                </Grid>
                <Grid item md={4} xs={12} >
                    <Card className="no-radius" style={{ height: 400 }}>
                    </Card>
                </Grid>

            </Grid>
        );
    }
}
Dashboard = withArtifex(Dashboard);
export { Dashboard };
