import React, { Component } from 'react';

import { Item } from './Item';
export class Cinema extends Component {
    render() {
        return (
            <div className="cinema">
                <Item></Item>
                <Item></Item>
            </div>
        );
    }
}
