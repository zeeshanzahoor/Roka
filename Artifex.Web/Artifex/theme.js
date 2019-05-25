import { MuiThemeProvider, createMuiTheme } from '@material-ui/core/styles';
const theme = createMuiTheme({
    palette: {
        primary: {
            light: "#f57f29",
            main: "#f57f29",
            dark: "#f57f29",
            contrastText: "#fff",
        },
    },
});
export default theme;