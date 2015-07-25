var PaginationList = React.createClass({
	render: function() {
		var itemNodes = this.props.data.map(function(item){
			return (
				<Item key={item.Id}>
					<h4>{item.Name}</h4>
					<h5>{item.Age}</h5>
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