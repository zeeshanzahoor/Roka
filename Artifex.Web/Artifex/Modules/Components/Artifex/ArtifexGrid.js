import React, { Component } from "react";
import { Paper, Select } from '@material-ui/core';
import {
    Grid, Table,
    VirtualTable,
    TableHeaderRow,
    TableSelection,
    PagingPanel
} from '@devexpress/dx-react-grid-material-ui';

import {
    SelectionState,
    IntegratedSelection,
    PagingState,
    CustomPaging
} from '@devexpress/dx-react-grid';

import { CircularProgress } from '@material-ui/core'
import { relative } from "path";


class ArtifexGrid extends React.PureComponent {
    constructor(props) {
        super(props);

        this.state = {
            columns: this.props.Columns,
            rows: [],
            currentPage: 0,
            pageSize: this.props.PageSize || 15,
            selection: [],
            pageSizes: this.props.PageSizeList || [],
            totalCount: 0,
            loading: true,
        };

    }
    changePageSize = (pageSize) => {
        this.setState({
            loading: true,
            pageSize
        });
        this.RefreshData(this.state.currentPage);
    }
    changeSelection = (selection) => {
         this.setState({ selection });
    };
    changeCurrentPage = (currentPage) => {
        this.setState({
            loading: true,
            currentPage,
        });
        this.RefreshData(currentPage);
    };

    RefreshData(currentPage) {
        var url = this.props.DataPath;
        fetch(url, {
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            method: 'POST',
            body: JSON.stringify({
                PageSize: this.state.pageSize,
                CurrentPage: currentPage,
            }),
        })
        .then((response) => {
            return response.json();
        })
        .then((result) => {
            this.setState({
                rows: result.data,
                totalCount: result.total,
                loading: false,
                currentPage
            });
        })
        .catch(() => this.setState({ loading: false }));
    }
    componentDidMount() {
        this.RefreshData();
    }
    render() {
        const {
            rows, columns, pageSize, pageSizes, currentPage, selection, totalCount, loading
        } = this.state;
        return (
            <Paper style={{ borderRadius: 0, position: 'relative' }}>
                <Grid
                    rows={rows}
                    selection={selection}
                    columns={columns}>
                    {this.props.Selectable && <SelectionState selection={selection} onSelectionChange={this.changeSelection} />}
                    {this.props.Selectable && <IntegratedSelection />}

                    <PagingState
                        currentPage={currentPage}
                        onCurrentPageChange={this.changeCurrentPage}
                        pageSize={pageSize}
                        onPageSizeChange={this.changePageSize}
                    />
                    <CustomPaging totalCount={totalCount} />
                    <Table />
                    <TableHeaderRow />
                    {this.props.Selectable && <TableSelection />}

                    {loading &&
                        <div style={styles.LoadingWrapper}>
                            <CircularProgress style={styles.CircularProgress} />
                        </div>
                    }
                    <PagingPanel pageSizes={pageSizes} />
                </Grid>

            </Paper >
        );
    }
}
var styles = {
    LoadingWrapper: { position: 'absolute', width: '100%', height: '100%', background: 'black', opacity: 0.2 },
    CircularProgress: { position: 'absolute', left: '50%', top: '45%' }
};
export { ArtifexGrid };
