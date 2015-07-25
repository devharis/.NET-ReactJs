var PaginationNavigation = React.createClass({
	render: function() {
		return (
			<div className="paginationNavigation">
				<button onClick={this.decrementPage}>Previous</button>
				<span>{ this.props.page }</span>
				<button onClick={this.incrementPage}>Next</button>
			</div>
		);
	},
	incrementPage: function(e){
		this.props.page++;
		this.props.onPageChange();
	},
	decrementPage: function(e){
		this.props.page--;
		this.props.onPageChange();
	}
});

var PaginationBox = React.createClass({
	getInitialState: function() {
		return {
			data: [],
			page: 0,
			take: 2
		 }
	},
    loadItemsFromServer: function() {
	    var xhr = new XMLHttpRequest();
	    xhr.open('get', 'items?page=' + this.state.page + '&take=' + this.state.take, true);
	    xhr.onload = function() {
	      var data = JSON.parse(xhr.responseText);
	      this.setState({ data: data });
	    }.bind(this);
	    xhr.send();
    },
	componentDidMount() {
		this.loadItemsFromServer();
	},
	render: function() {
		return (
			<div className="paginationBox">
				<h1>Pagination</h1>
				<PaginationList data={this.state.data} />
				<PaginationNavigation onPageChange={this.loadItemsFromServer} page={this.state.page} take={this.state.take} />
			</div>
		);
	}
});

React.render(
	<PaginationBox />,
	document.getElementById('content')
);


