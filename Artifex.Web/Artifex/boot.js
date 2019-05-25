import "./css/site.css";
import "bootstrap";
import React, { Component } from "react";
import * as ReactDOM from "react-dom";
import { AppContainer } from "react-hot-loader";
import { BrowserRouter, Route, Redirect, Switch} from "react-router-dom";

import { LoginPage } from "./Modules/Account";
import PersistentDrawer from "./Modules/Components/Drawer/PersistentDrawer";
import { Provider } from 'react-redux';
import { store } from './core/store/store';
import { MuiThemeProvider, createMuiTheme } from '@material-ui/core/styles';
import theme from './theme';



function renderApp() {
  const baseUrl = document.getElementsByTagName("base")[0].getAttribute("href");
  ReactDOM.render(
      <AppContainer>
          <MuiThemeProvider theme={theme}>
          <BrowserRouter basename={baseUrl}>
              <Provider store={store}>
                  <Switch>
                      <Route exact path="/login" name="Login Page" component={LoginPage} />
                      <Route path="/" name="Home" component={PersistentDrawer} />
                  </Switch>
              </Provider>
              </BrowserRouter>
          </MuiThemeProvider>
    </AppContainer>,
    document.getElementById("react-app")
  );
}

renderApp();
if (module.hot) {
  module.hot.accept("./routes", () => {
    routes = require("./routes").routes;
    renderApp();
  });
}
