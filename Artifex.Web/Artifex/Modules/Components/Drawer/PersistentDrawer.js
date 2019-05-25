import React from 'react';
import PropTypes from 'prop-types';
import classNames from 'classnames';
import { withStyles } from '@material-ui/core/styles';
import { List, ListItem, ListItemText, Drawer, AppBar, Toolbar, MenuItem, Typography, TextField, Divider, IconButton, Button } from '@material-ui/core';


import { Menu, ChevronLeft, ChevronRight, Inbox, Mail, AccountCircle, Notifications } from '@material-ui/icons';

import { Link, NavLink, Route, Switch, Redirect } from "react-router-dom";

import { GridTest } from "Artifex/Modules/Test/GridTest";
import { Dashboard } from "Artifex/Modules/Dashboard";

const routeData = require('Artifex/routes');

const menuData = require('Artifex/menu');


const drawerWidth = 240;

const styles = theme => ({
    root: {
        flexGrow: 1,
    },
    appFrame: {
        zIndex: 1,
        overflow: 'hidden',
        position: 'relative',
        display: 'flex',
        width: '100%',
    },
    appBar: {
        position: 'absolute',
        transition: theme.transitions.create(['margin', 'width'], {
            easing: theme.transitions.easing.sharp,
            duration: theme.transitions.duration.leavingScreen,
        }),
    },
    appBarShift: {
        width: `calc(100% - ${drawerWidth}px)`,
        transition: theme.transitions.create(['margin', 'width'], {
            easing: theme.transitions.easing.easeOut,
            duration: theme.transitions.duration.enteringScreen,
        }),
    },
    'appBarShift-left': {
        marginLeft: drawerWidth,
    },
    menuButton: {
        marginLeft: 12,
        marginRight: 20,
    },
    actionButton: {
        marginLeft: 2,
        marginRight: 12,
    },
    hide: {
        display: 'none',
    },
    drawerPaper: {
        position: 'relative',
        width: drawerWidth,
    },
    drawerHeader: {
        display: 'flex',
        alignItems: 'center',
        padding: '8px 25px 0px 25px',
    },
    content: {
        flexGrow: 1,
        backgroundColor: theme.palette.background.default,
        padding: theme.spacing.unit * 3,
        transition: theme.transitions.create('margin', {
            easing: theme.transitions.easing.sharp,
            duration: theme.transitions.duration.leavingScreen,
        }),
        padding: 16,
    },
    'content-left': {
        marginLeft: -drawerWidth,
    },
    contentShift: {
        transition: theme.transitions.create('margin', {
            easing: theme.transitions.easing.easeOut,
            duration: theme.transitions.duration.enteringScreen,
        }),
    },
    'contentShift-left': {
        marginLeft: 0,
    },
});



class PersistentDrawer extends React.Component {
    state = {
        open: true,
    };

    handleDrawerOpen = () => {
        this.setState({ open: !this.state.open });
    };

    render() {
        const { classes, theme } = this.props;
        const { open } = this.state;


        return (
            <div className={classes.root}>
                <div className={classes.appFrame}>
                    <AppBar
                        className={classNames(classes.appBar, {
                            [classes.appBarShift]: open,
                            [classes['appBarShift-left']]: open,
                        })}>
                        <Toolbar disableGutters={true}>
                            <IconButton
                                color="inherit"
                                aria-label="open drawer"
                                onClick={this.handleDrawerOpen}
                                className={classNames(classes.menuButton)}>
                                <Menu />
                            </IconButton>

                            <Typography variant="title" color="inherit" style={{ flex: 1, }} noWrap>
                                DC Bank
                            </Typography>
                            <IconButton color="inherit">
                                <Mail />
                            </IconButton>
                            <IconButton color="inherit" >
                                <Notifications />
                            </IconButton>
                            <IconButton color="inherit" className={classNames(classes.actionButton)}>
                                <AccountCircle />
                            </IconButton>
                        </Toolbar>
                    </AppBar>

                    <Drawer
                        variant="persistent"
                        open={open}
                        classes={{
                            paper: classes.drawerPaper,
                        }}>
                        <div className={classes.drawerHeader}>
                            <img src="/assets/logo.svg" height="47" />
                        </div>
                        <List component="nav">
                            <Divider />
                            {
                                menuData.menuData.map((menuItem, i) => {
                                    return (<Link key={i} to={menuItem.Url} style={{ textDecoration: 'none' }}>
                                        <ListItem button>
                                            <Inbox color="primary" />
                                            <ListItemText primary={menuItem.Title} />
                                        </ListItem>
                                    </Link>);
                                })
                            }
                            <Divider />
                        </List>
                    </Drawer>
                    <main
                        className={classNames(classes.content, classes['content-left'], {
                            [classes.contentShift]: open,
                            [classes['contentShift-left']]: open,
                        })} >
                        <div className={classes.drawerHeader} />
                        <div style={{ marginTop: 57, }}>
                            <Switch>
                                {routeData.routeData.map((route, i) => <Route
                                    path={route.path}
                                    key={i}
                                    render={props => (
                                        <route.component {...props} routes={route.routes} />
                                    )}
                                />)}
                                <Redirect from="/" to="/home" />
                            </Switch>
                        </div>
                    </main>
                </div>
            </div>
        );
    }
}

PersistentDrawer.propTypes = {
    classes: PropTypes.object.isRequired,
    theme: PropTypes.object.isRequired,
};

export default withStyles(styles, { withTheme: true })(PersistentDrawer);