var PaginationList = React.createClass({
	render() {
		var itemNodes = this.props.data.map(function(item){
			return (
				<Item>
					{item.Name}
				</Item>
			);
		});
		return (
			<div className="paginationList">
				{itemNodes}
			</div>
		);
	}
});