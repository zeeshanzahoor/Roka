import React, { Component } from "react";
import { withArtifex, ArtifexGrid, ArtifexComponent } from 'Artifex/Modules/Components/Artifex';

const Columns = [
    { name: 'id', title: 'ID' },
    { name: 'name', title: 'Name' },
    { name: 'surname', title: 'Surname' },
];

class GridTest extends ArtifexComponent {
    render() {
        return (
            <ArtifexGrid
                Columns={Columns}
                PageSize={5}
                DataPath="/SampleData/FillUserGrid/"
            ></ArtifexGrid>
        );
    }
}
GridTest = withArtifex(GridTest);
export { GridTest };
