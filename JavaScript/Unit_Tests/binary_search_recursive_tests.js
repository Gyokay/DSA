const assert = require('chai').assert
const binarySearch = require('../binary_search_recursive')

describe('Binary search - recursive', () => {
	describe('binarySearch', () => {
		it('should return -1 if non-existing number in the array is passed', () => {
			const arr = [1, 2, 3, 4, 5]
			const numberToFind = 6
			let result = binarySearch(arr, 0, arr.length - 1, numberToFind, -1)

			assert.equal(result, -1)
		})

		it('sould return correct index when existing number in the array is passed', () => {
			const arr = [1, 2, 3, 4]
			const numberToFind = 3
			let result = binarySearch(arr, 0, arr.length - 1, numberToFind)

			assert.equal(result, 2)
		})

		it('should work as expected if arrays of different sizes are passed', () => {
			const firstIndex = 0
			const oddSizedArr = [1, 5, 8]
			const evenSizedArr = [6, 9, 10, 11, 35, 89, 100, 101]
			const result = binarySearch(evenSizedArr, 0, evenSizedArr.length - 1, 9)
			const shortArr = [0]
			const emptyArr = []

			assert.equal(binarySearch(oddSizedArr, firstIndex, oddSizedArr.length - 1, 8), 2)
			assert.equal(binarySearch(evenSizedArr, firstIndex, evenSizedArr.length - 1, 9), 1)
			assert.equal(binarySearch(shortArr, firstIndex, shortArr.length - 1, 5), -1)
			assert.equal(binarySearch(emptyArr, firstIndex, emptyArr.length - 1, 5), -1)
		})
	})
})

